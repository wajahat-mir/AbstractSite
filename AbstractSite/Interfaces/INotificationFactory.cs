using AbstractSite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractSite.Interfaces
{
    public interface INotificationFactory
    {
        public NameViewModel name();
        public SubjectViewModel subject();
        public SubmitViewModel submit();
    }
}
