using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// class 前面的关键字被称为访问修饰符
    /// 1、public 公共的
    /// 2、protected 受保护的类，只有子类可访问
    /// 3、private 私有的
    /// 4、internal 程序集内可访问
    /// 5、sealed 不允许被继承
    /// </summary>
    public class Program
    {
        //Main方法是整个软件程序的入口
        static void Main(string[] args)
        {
            //激活并触发事件
            new SystemEvent().EventTrigger();
            return;

            EventIntroduction e = new EventIntroduction();
            RegistedEvent r = new RegistedEvent(e);
            e.TrigEvent(e);



            //值类型
            int x = 42;
            //引用类型
            string str = "hello world";
            Console.WriteLine("值类型：{0} \n\t 引用类型：{1}",
                x, str);
        }

        private static void E_EventSelf(object send, EventArgs args)
        {
            if (send is Program)
            {

            }
        }
    }
}
