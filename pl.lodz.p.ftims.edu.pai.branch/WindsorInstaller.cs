using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using pl.lodz.p.ftims.edu.pai.branch.BusinessService;
using pl.lodz.p.ftims.edu.pai.branch.dal;
using pl.lodz.p.lftims.edu.pai.branch.dal;

namespace pl.lodz.p.ftims.edu.pai.branch
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                           Component.For<IUnitOfWork, EfUnitOfWork>(),
                           Component.For<ITime, Time>(),
                           Component.For<ITimeManagementService, TimeManagementService>()
                );
        }
    }
}