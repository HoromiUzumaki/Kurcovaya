using System.Linq;
using System.Windows;

namespace Учет_посещаемости
{
    /// <summary>
    /// Логика взаимодействия для StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        private int _currentUserId;
        public StudentWindow(int? currentUserId)
        {
            InitializeComponent();
            _currentUserId = (int)currentUserId;

            if (currentUserId.HasValue) 
            {
                
                using (var db = new Students_absencesEntities())
                {
                    var user = db.User.FirstOrDefault(u => u.Id_student == currentUserId.Value);
                    if (user != null)
                    {
                        var student = db.Student.FirstOrDefault(s => s.Id_student == user.Id_student);
                        if (student != null)
                        {
                            Info.Content = $"{student.Name} {student.Surname}";
                        }
                    }
                }
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
                                  Номер_группы = z.Id_group  + " " + z.Group_Name,
                                  Специальность = sz.Specialization_Name
                           };
                grid.ItemsSource = Grup.ToList();
            }
        }

        
        private void Predm_Click(object sender, RoutedEventArgs e)
        {
            using (var bd = new Students_absencesEntities())
            {
                var Predm = from z in bd.Subject
                           select new
                           {
                              
                               Наименование_предмета = z.Name
                               
                           };
                grid.ItemsSource = Predm.ToList();
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

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
