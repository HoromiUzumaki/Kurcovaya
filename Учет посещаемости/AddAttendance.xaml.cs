using System;
using System.Linq;
using System.Windows;

namespace Учет_посещаемости
{
    /// <summary>
    /// Логика взаимодействия для AddAttendance.xaml
    /// </summary>
    public partial class AddAttendance : Window
    {
        public AddAttendance()
        {
            InitializeComponent();
            LoadStudents();
            LoadSubjects();
            LoadReason();
        }
        private void LoadStudents()
        {
            using (var bd = new Students_absencesEntities())
            {
                var students = bd.Student.Select(s => new { s.Id_student, FullName = s.Surname + " " + s.Name + " " + s.Middle_Name }).ToList();
                Fio.ItemsSource = students;
                Fio.DisplayMemberPath = "FullName"; 
                Fio.SelectedValuePath = "Id_student"; 
            }
        }

        private void LoadSubjects()
        {
            using (var bd = new Students_absencesEntities())
            {
                var subjects = bd.Subject.Select(s => new { s.Id_subject, s.Name }).ToList();
                Predmet.ItemsSource = subjects;
                Predmet.DisplayMemberPath = "Name"; 
                Predmet.SelectedValuePath = "Id_subject"; 
            }
        }
        private void LoadReason()
        {
            using (var bd = new Students_absencesEntities())
            {
               
                var reasons = (from a in bd.Attendance
                               select new
                               {
                                   Display = a.Reason,
                                   Value = a.Id_attendence
                               }).Distinct().ToList(); 

                Prich.ItemsSource = reasons;
                Prich.DisplayMemberPath = "Display";
                Prich.SelectedValuePath = "Value";
            }
        }



        private void Cohr_Click(object sender, RoutedEventArgs e)
        {
            
            if (Fio.SelectedValue == null || Predmet.SelectedValue == null || Dat.SelectedDate == null || Prich.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            using (var bd = new Students_absencesEntities())
            {

                var newAttendance = new Attendance
                {
                    Id_attendence = Convert.ToInt32(Nom.Text),
                    Id_student = (int)Fio.SelectedValue,
                    Subject = (int)Predmet.SelectedValue,
                    Date = Dat.SelectedDate.Value,
                    Reason = Prich.Text
                };

                
                bd.Attendance.Add(newAttendance);
                bd.SaveChanges(); 

                MessageBox.Show("Изменения успешно сохранены!");
                TeacherWindow mw = new TeacherWindow();
                mw.Show(); 
                this.Close(); 
            }
        }
    }
    
}
    

