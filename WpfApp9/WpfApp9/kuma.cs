using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp8
{
    //public class kuma
    //{
    //    public string Name { get; set; }
    //    public string Note { get; set; }
    //    public int Priority { get; set; }
    //    public kumaType Type { get; set; }
    //}

    //public enum kumaType { Coding, Testing, Support }

    //public class kumas : List<kuma>
    //{
    //    public kumas()
    //    {
    //        Add(new kuma { Name = "Data loading", Note = "Необхідна тестова робота з БД", Priority = 2, Type = kumaType.Testing });
    //        Add(new kuma { Name = "Log class", Note = "Finish this work", Priority = 2, Type = kumaType.Coding });
    //        Add(new kuma { Name = "IoC Usage", Note = "Find more info", Priority = 4, Type = kumaType.Coding });
    //        Add(new kuma { Name = "Urgent bug fixing", Note = "Problem with class C", Priority = 1, Type = kumaType.Support });
    //        Add(new kuma { Name = "UI development", Note = "Make markup for Main Window", Priority = 1, Type = kumaType.Coding });
    //        Add(new kuma { Name = "Help Doc", Note = "Write technocak documentation", Priority = 3, Type = kumaType.Support });
    //        Add(new kuma { Name = "New project", Note = "Plan the meeting", Priority = 1, Type = kumaType.Support });
    //    }
    //}

    //public class TaskTemplateSelector : DataTemplateSelector
    //{
    //    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    //    {
    //        if (item is kuma task)
    //        {
    //            Window window = Application.Current.MainWindow;

    //            if (task.Priority == 1)
    //            {
    //                return window.FindResource("importantTask") as DataTemplate;
    //            }
    //            else
    //            {
    //                DataTemplateKey templateKey = new DataTemplateKey(typeof(kuma));
    //                return window.FindResource(templateKey) as DataTemplate;
    //            }
    //        }

    //        return null;
    //    }
    //}
}
