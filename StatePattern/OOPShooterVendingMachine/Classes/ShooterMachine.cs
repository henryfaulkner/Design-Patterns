using System;
using System.IO;

namespace OOPShooterVendingMachine
{
    public class ShooterMachine
    {
        public IState noDollarState { get; set; }
        public IState hasDollarState { get; set; }
        public IState sellState { get; set; }
        public IState soldOutState { get; set; }

        public IState state { get; set; }
        public int count { get; set; }

        public ShooterMachine(int count)
        {
            noDollarState = new NoDollarState(this);
            hasDollarState = new HasDollarState(this);
            sellState = new SellState(this);
            soldOutState = new SoldOutState(this);
            state = soldOutState;

            this.count = count;
            if (count > 0)
            {
                this.state = noDollarState;
            }
        }

        public void InsertDollar()
        {
            state.InsertDollar();
        }

        public void EjectDollar()
        {
            state.EjectDollar();
        }

        public void PressButton()
        {
            state.PressButton();
            state.DispenseLiquor();
        }
    }
}