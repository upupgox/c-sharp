namespace ConsoleApp
{
    using System;
    /// <summary>
    /// 抽象类型 与接口相似
    /// </summary>
    public abstract class AbstractType
    {
        public AbstractType(string s) { }//这样空的构造器就被抹掉了
        private string tag;//字段不能修饰为abstract
        public abstract string Tag { get; set; }
        public void FuncA() { }
        public abstract void FuncB();//抽象方法无实现***
        public virtual void FuncC() { }//虚方法必须有实现
    }
    
    public class ImplementAbstractType : AbstractType
    {
        //如果AbstractType中没有定义有参的构造，默认是不显式实现抽象类构造的
        public ImplementAbstractType(string s) : base(s)
        {
        }
        public override string Tag
        {
            get { throw new NotImplementedException(); }

            set { throw new NotImplementedException(); }
        }

        public override void FuncB()
        {
            //AbstractType abstactType = new AbstractType();//error:Cannot create an instance of abstract or interface AbstractType
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 测试抽象类的构造器是否可以在不继承它的类中使用
    /// </summary>
    public class TestAbstractBuilder
    {
    }
}
