using AutoMapper;

namespace pl.lodz.p.ftims.edu.pai.central.Infrastructure
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration MapperConfiguration;

        public static void RegisterMappings()
        {
            MapperConfiguration = new MapperConfiguration(cfg => {
                cfg.CreateMap<entity.Employee, dto.Employee>().ReverseMap();
                cfg.CreateMap<dto.CreateEmployee, entity.Employee>();
                cfg.CreateMap<entity.Project, dto.Project>().ReverseMap();
                cfg.CreateMap<dto.CreateProject, entity.Project>();
                cfg.CreateMap<entity.Task, dto.Task>().ReverseMap();
                cfg.CreateMap<dto.CreateTask, entity.Task>();
                cfg.CreateMap<dto.Timesheet, entity.Timesheet>().ReverseMap();
                cfg.CreateMap<dto.Branch, entity.Branch>().ReverseMap();
                cfg.CreateMap<dto.CreateBranch, entity.Branch>();
                cfg.CreateMap<dto.CreateTimesheet, entity.Timesheet>();
                cfg.CreateMap<dto.Entry, entity.Entry>().ReverseMap();
                cfg.CreateMap<dto.CreateEntry, entity.Entry>();
                cfg.CreateMap<dto.Audit, entity.Audit>().ReverseMap();
            });
        }
    }
}