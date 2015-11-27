using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Visitor
{
    /// <summary>
    /// The 'ConcreteElement' class.
    /// </summary>
    public class Employee : IElement
    {
        public string name { set; get; }            // Employee's name
        public int salary { set; get; }             // 應領薪資
        //public int vocationDays { set; get; }       // 休假天數

        public Employee() { }   // default Constructor

        // Constructor
        public Employee(string _name, int _salary)
        {
            this.name = _name;
            this.salary = _salary;
            //this.vocationDays = vDays;
        }

        public void Accept(Visitor visitor)
        {
            visitor.VisitEmployee(this);
        }        
    }

    /// <summary>
    /// The 'ConcreteElement' class.
    /// </summary>
    public class Clerk : Employee
    {
        // Constructor
        public Clerk(string _name, int _salary)
            : base(_name, _salary)
        {}
    }

    /// <summary>
    /// The 'ConcreteElement' class.
    /// </summary>
    public class Manager : Employee
    {
        // Constructor
        public Manager(string _name, int _salary)
            : base(_name, _salary)
        {}  
    }

    public class Office : IElement
    {       
        // 包括租金、水電費、辦公用具等採購費用
        // 此為簡化；實作應有 calc支出費用() 計算邏輯函數
        public int 支出費用 { set; get; }
        public string name {set;get;}   // 辦公室名稱

        // Constructor
        public Office(string _name, int expense)
        {
            this.支出費用 = expense;
            this.name = _name;
        }

        // realize the 'Accept()' operation.
        public void Accept(Visitor visitor)
        {
            visitor.VisitOffice(this);
        }
    }
}
