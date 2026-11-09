using DecanatPRO.WinForms;
using Model;

namespace Presenter
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StudentView view = new StudentView();
            new StudentPresenter(view, new StudentModel());

            Application.Run(view);
        }
    }
}
