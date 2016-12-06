﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            });
        }
    }
}