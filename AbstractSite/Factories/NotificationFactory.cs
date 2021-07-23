using AbstractSite.Enums;
using AbstractSite.Interfaces;
using AbstractSite.ViewModels;

namespace AbstractSite.Factories
{
    public abstract class NotificationFactory: INotificationFactory
    {
        
        private readonly NotificationState _state;

        public NotificationFactory(NotificationState state)
        {
            _state = state;
        }

        public virtual NameViewModel name()
        {
            return new NameViewModel
            {
                viewName = "_Name",
                disabled = _state == NotificationState.VIEW ? "disabled" : "",
                placeHolder = "New Reviews"
            };
        }

        public virtual SubjectViewModel subject()
        {
            return new SubjectViewModel
            {
                viewName = "_Subject",
                disabled = _state == NotificationState.VIEW ? "disabled" : "",
                placeHolder = "Default"
            };
        }

        public virtual SubmitViewModel submit()
        {
            return new SubmitViewModel
            {
                viewName = "_Submit",
                disabled = _state == NotificationState.VIEW ? "disabled" : "",
                submitFunc = _state == NotificationState.VIEW ? "" : "submitReviewConfiguration()"
            };
        }
    }
}
