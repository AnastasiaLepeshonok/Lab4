using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class StudentModel : IModel<Student>
    {
        private readonly List<Student> _students = new List<Student>();

        public event DataChangedDelegate? DataChanged;

        public void Delete(int index)
        {
            if (index < 0 || index >= _students.Count)
                return;

            _students.RemoveAt(index);
            InvokeDataChanged();
        }

        public void Insert(Student item)
        {
            _students.Add(item);
            InvokeDataChanged();
        }

        private void InvokeDataChanged()
        {
            List<List<object>> list = new List<List<object>>();

            for (int i = 0; i < _students.Count; i++)
            {
                Student item = _students[i];
                list.Add(new List<object>());
                list[i].Add(item.Name);
                list[i].Add(item.Speciality);
                list[i].Add(item.Group);
            }

            DataChanged?.Invoke(list);
        }
    }
}
