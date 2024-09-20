using EMS_BusinessEntity;
using EMS_New.DataEntity;

namespace EMS_New.Common
{
    public static class Helper
    {
        public static UserViewModel ToViewModel(this User user)
        {
            UserViewModel viewModel = new UserViewModel();
            viewModel.FullName = $"{user.Name} {user.City}";
            viewModel.Name = user.Name ;
            viewModel.City = user.City ;
            viewModel.Id = user.Id ;

            return viewModel;
        }

        public static List<UserViewModel> ToViewModel(this List<User> user)
        {
            return user.Select(y=>y.ToViewModel()).ToList();
        }

        public static User ToDataModel(this UserViewModel user)
        {
            User dataModel = new User();
            dataModel.Name = user.Name;
            dataModel.City = user.City;
            dataModel.Id = user.Id;
            dataModel.IsDeleted = false;

            return dataModel;
        }
    }
}