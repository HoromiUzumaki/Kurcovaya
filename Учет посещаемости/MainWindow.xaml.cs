using System.Linq;
using System.Windows;

namespace Учет_посещаемости
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            if (Log.Text == "" || Passw.Password == "")
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            using (var db = new Students_absencesEntities()) 
            {
                
                var user = db.User.FirstOrDefault(u => u.Login == Log.Text && u.Password == Passw.Password);

                
                if (user == null)
                {
                    MessageBox.Show("Неверно введен логин или пароль");
                }
                else
                {
                    MessageBox.Show("Успешная авторизация!");
                    var userType = db.User_type.FirstOrDefault(t => t.Id_types == user.Type_User);

                   
                    if (userType != null)
                    {
                        switch (userType.Type_Name)
                        {
                            case "Admin":
                                
                                GeneralWindow adminWindow = new GeneralWindow();
                                adminWindow.Show();
                                Close();
                                break;
                            case "Teacher":
                               
                                TeacherWindow teacherWindow = new TeacherWindow();
                                teacherWindow.Show();
                                Close();
                                break;
                            case "Student":
                                
                                StudentWindow studentWindow = new StudentWindow(user.Id_student);
                                studentWindow.Show();
                                Close();
                                break;
                            default:
                                MessageBox.Show("Неизвестный тип пользователя");
                                break;
                        }                    
                    }
                    else
                    {
                        MessageBox.Show("Ошибка получения типа пользователя");
                    }
                }
            }
        }
    }
}
