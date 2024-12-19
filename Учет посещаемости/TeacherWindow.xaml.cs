using System.Linq;
using System.Windows;
using OfficeOpenXml;
using System.IO;
using System;
using Microsoft.Win32;
using System.Windows.Controls;

namespace Учет_посещаемости
{
    /// <summary>
    /// Логика взаимодействия для TeacherWindow.xaml
    /// </summary>
    public partial class TeacherWindow : Window
    {
        public TeacherWindow()
        {
            InitializeComponent();
        }
        private void Out_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Grup_Click(object sender, RoutedEventArgs e)
        {
            using (var bd = new Students_absencesEntities())
            {
                var Grup = from z in bd.Group
                           join sz in bd.Specialization on z.Specialization equals sz.Id_specialization
                           select new
                           {
                               Номер_группы = z.Id_group + " " + z.Group_Name,
                               Специальность = sz.Specialization_Name
                           };
                grid.ItemsSource = Grup.ToList();
            }
        }
        private void Attend_Click(object sender, RoutedEventArgs e)
        {
            using (var bd = new Students_absencesEntities())
            {
                var Attend = from z in bd.Attendance
                             join sz in bd.Student on z.Id_student equals sz.Id_student
                             join pz in bd.Subject on z.Subject equals pz.Id_subject
                             select new
                             {
                                 Студент = sz.Surname + " " + sz.Name + " " + sz.Middle_Name,
                                 Предмет = pz.Name,
                                 Дата = z.Date,
                                 Причина_отсутствия = z.Reason
                             }; 
                grid.ItemsSource = Attend.ToList();
            }
        }

       
       

        private void New_Pos_Click(object sender, RoutedEventArgs e)
        {
            AddAttendance mw = new AddAttendance();
            mw.Show();
            this.Hide();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string searchQuery = SearchBox.Text;

            using (var bd = new Students_absencesEntities())
            {
                var studentSearch = from z in bd.Student
                                    join attend in bd.Attendance on z.Id_student equals attend.Id_student
                                    join subject in bd.Subject on attend.Subject equals subject.Id_subject
                                    where (z.Surname + " " + z.Name + " " + z.Middle_Name).Contains(searchQuery)
                                    select new
                                    {
                                        Студент = z.Surname + " " + z.Name + " " + z.Middle_Name,
                                        Предмет = subject.Name,
                                        Дата = attend.Date,
                                        Причина_отсутствия = attend.Reason
                                    };

                
                var results = studentSearch.ToList();

                
                grid.ItemsSource = results;

            }
        }
 
        private void ReportToExcel_Click(object sender, RoutedEventArgs e)
        {
            using (var bd = new Students_absencesEntities())
            {
                var Attend = from z in bd.Attendance
                             join sz in bd.Student on z.Id_student equals sz.Id_student
                             join pz in bd.Subject on z.Subject equals pz.Id_subject
                             select new
                             {
                                 Студент = sz.Surname + " " + sz.Name + " " + sz.Middle_Name,
                                 Предмет = pz.Name,
                                 Дата = z.Date,
                                 Причина_отсутствия = z.Reason
                             };

                var dataToExport = Attend.ToList();

                
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Сохранить отчет";
                saveFileDialog.FileName = "Отчет"; 

                if (saveFileDialog.ShowDialog() == true)
                {
                    string filePath = saveFileDialog.FileName;

                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        var worksheet = excelPackage.Workbook.Worksheets.Add("Отчет");

                        worksheet.Cells[1, 1].Value = "Студент";
                        worksheet.Cells[1, 2].Value = "Предмет";
                        worksheet.Cells[1, 3].Value = "Дата";
                        worksheet.Cells[1, 4].Value = "Причина отсутствия";

                        for (int i = 0; i < dataToExport.Count; i++)
                        {
                            worksheet.Cells[i + 2, 1].Value = dataToExport[i].Студент;
                            worksheet.Cells[i + 2, 2].Value = dataToExport[i].Предмет;
                            worksheet.Cells[i + 2, 3].Value = dataToExport[i].Дата;
                            worksheet.Cells[i + 2, 4].Value = dataToExport[i].Причина_отсутствия;
                        }
                        worksheet.Column(3).Style.Numberformat.Format = "dd.MM.yyyy";
                        FileInfo excelFile = new FileInfo(filePath);
                        excelPackage.SaveAs(excelFile);
                    }
                    MessageBox.Show("Отчет успешно сохранен!");
                }
                grid.ItemsSource = dataToExport;
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (grid.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, выберите запись для удаления.");
                    return;
                }

                
                var selectedAttendance = grid.SelectedItem as dynamic; 
                if (selectedAttendance != null)
                {
                    
                    int attendanceId = selectedAttendance.Id_attendence; 

                    using (var bd = new Students_absencesEntities())
                    {
                        
                        var attendanceRecord = bd.Attendance.FirstOrDefault(a => a.Id_attendence == attendanceId);
                        if (attendanceRecord != null)
                        {
                            bd.Attendance.Remove(attendanceRecord);
                            bd.SaveChanges();
                            MessageBox.Show("Запись успешно удалена!");
                        }
                        else
                        {
                            MessageBox.Show("Запись не найдена.");
                        }
                    }

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении записи: {ex.Message}");
            }
        }


    }
}


