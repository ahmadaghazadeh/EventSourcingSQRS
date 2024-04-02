﻿namespace LoanApplications.Domain.Model.LoanApplications.States
{
    public abstract class LoanApplicationState
    {
        public virtual bool CanReject()=>false;
        public virtual bool CanAccept()=>false;
    }
}
