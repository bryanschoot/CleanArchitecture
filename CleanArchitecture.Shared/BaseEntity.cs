using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Shared
{
    public class BaseEntity
    {
        public int Id { get; set; }

        private List<INotification>? _notifications;
        public IReadOnlyList<INotification>? Notifications => _notifications?.AsReadOnly();

        public void AddNotificication(INotification notification)
        {
            _notifications ??= new List<INotification>();
            _notifications.Add(notification);
        }

        public void RemoveNotification(INotification notification)
        {
            _notifications?.Remove(notification);
        }

        public void ClearNotifications()
        {
            _notifications?.Clear();
        }
    }
}
