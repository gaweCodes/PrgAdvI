﻿namespace SimpleDelegateAndTaskTutorial.Event
{
    public delegate void EventHandler(Account sender, OverDrawnEventArgs e);
    public class Account
    {
        public event EventHandler OverDrawn;
        private double _balance;
        public Account(double initDeposit)
        {
            _balance = initDeposit;
        }
        public void Credit(double amt)
        {
            _balance += amt;
        }
        public void Debit(double amt)
        {
            _balance -= amt;
            if (_balance < 0)
                OverDrawn?.Invoke(this, new OverDrawnEventArgs(_balance));
        }
    }
}
