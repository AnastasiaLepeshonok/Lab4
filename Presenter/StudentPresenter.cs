using DecanatPRO.WinForms;
using Model;

namespace Presenter
{
    internal class StudentPresenter
    {
        private readonly IModel<Student> model;

        public StudentPresenter(IView view, IModel<Student> model)
        {
            this.model = model;

            model.DataChanged += view.RedrawForm;

            view.AddDataEvent += OnAddData;
            view.DeleteDataEvent += model.Delete;
        }

        // Распаковка object-пакетов и сборка экземпляра Student
        private void OnAddData(IEnumerable<object> data)
        {
            List<object> list = new List<object>(data);

            Student student = new Student();
            student.Name = list[0].ToString() ?? string.Empty;
            student.Speciality = list[1].ToString() ?? string.Empty;
            student.Group = list[2].ToString() ?? string.Empty;

            model.Insert(student);
        }
    }
}