using AbstractSite.Enums;
using AbstractSite.Interfaces;
using AbstractSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractSite.Factories
{
    public class ReviewNotificationFactory:NotificationFactory, INotificationFactory
    {
        private readonly IAccountProvider _accountProvider;

        public ReviewNotificationFactory(NotificationState state, IAccountProvider accountProvider): base(state)
        {
            _accountProvider = accountProvider;
        }

        public override SubjectViewModel subject()
        {
            var subjectModel = base.subject();

            subjectModel.placeHolder = _accountProvider.GetCustomSubject();
            return subjectModel;
        }
    }
}
