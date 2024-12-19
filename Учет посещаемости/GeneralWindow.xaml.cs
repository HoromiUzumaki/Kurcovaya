using System.IO;
using System;
using System.Linq;
using System.Windows;
using OfficeOpenXml;

namespace Учет_посещаемости
{
    /// <summary>
    /// Логика взаимодействия для GeneralWindow.xaml
    /// </summary>
    public partial class GeneralWindow : Window
    {
        public GeneralWindow()
        {
            InitializeComponent();
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Polzovatel_Click(object sender, RoutedEventArgs e)
        {
            using (var bd = new Students_absencesEntities())
            {
                var userAttendances = from user in bd.User
                                      join userType in bd.User_type on user.Type_User equals userType.Id_types
                                      select new
                                      {
                                          ID_пользователя = user.Id_user,
                                          Логин = user.Login,
                                          Пароль = user.Password,
                                          Тип_пользователя = userType.Description
                                      };

                grid.ItemsSource = userAttendances.ToList();
            }

        }

        private void AddPolzovatel_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ReportToExcel_Click(object sender, RoutedEventArgs e)
        {


            using (var bd = new Students_absencesEntities())
            {
                try
                {
                    var userAttendances = from user in bd.User
                                          join userType in bd.User_type on user.Type_User equals userType.Id_types
                                          select new
                                          {
                                              ID_пользователя = user.Id_user,
                                              Логин = user.Login,
                                              Пароль = user.Password,
                                              Тип_пользователя = userType.Description
                                          };

                    var dataToExport = userAttendances.ToList();

                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        var worksheet = excelPackage.Workbook.Worksheets.Add("User  Attendances");

                       
                        worksheet.Cells[1, 1].Value = "ID пользователя";
                        worksheet.Cells[1, 2].Value = "Логин";
                        worksheet.Cells[1, 3].Value = "Пароль";
                        worksheet.Cells[1, 4].Value = "Тип пользователя";

                       
                        for (int i = 0; i < dataToExport.Count; i++)
                        {
                            worksheet.Cells[i + 2, 1].Value = dataToExport[i].ID_пользователя;
                            worksheet.Cells[i + 2, 2].Value = dataToExport[i].Логин;
                            worksheet.Cells[i + 2, 3].Value = dataToExport[i].Пароль;
                            worksheet.Cells[i + 2, 4].Value = dataToExport[i].Тип_пользователя;
                        }

                       
                        var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "User  Attendances.xlsx");
                        FileInfo fileInfo = new FileInfo(filePath);
                        excelPackage.SaveAs(fileInfo);

                        MessageBox.Show("Данные успешно экспортированы на рабочий стол.");
                    }

                    
                    grid.ItemsSource = dataToExport;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при экспорте данных: {ex.Message}");
                }
            }

           

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            
            var selectedUser = grid.SelectedItem as dynamic; 

            if (selectedUser != null)
            {
                int userIdToDelete = selectedUser.ID_пользователя; 

                using (var bd = new Students_absencesEntities())
                {
                    
                    var userToDelete = bd.User.FirstOrDefault(u => u.Id_user == userIdToDelete);

                    if (userToDelete != null)
                    {
                        
                        bd.User.Remove(userToDelete);

                       
                        bd.SaveChanges();

                       
                        var userAttendances = from user in bd.User
                                              join userType in bd.User_type on user.Type_User equals userType.Id_types
                                              select new
                                              {
                                                  ID_пользователя = user.Id_user,
                                                  Логин = user.Login,
                                                  Пароль = user.Password,
                                                  Тип_пользователя = userType.Description
                                              };

                        grid.ItemsSource = userAttendances.ToList();

                        MessageBox.Show("Пользователь успешно удален.");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для удаления.");
            }
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

        private void Cpez_Click(object sender, RoutedEventArgs e)
        {
            using (var bd = new Students_absencesEntities())
            {
                var Cpez = from z in bd.Specialization
                           select new
                           {
                               Номер_специальности = z.Number_Specialization,
                               Наименование_специальности = z.Specialization_Name
                           };
                grid.ItemsSource = Cpez.ToList();
            }
        }
    }
}
