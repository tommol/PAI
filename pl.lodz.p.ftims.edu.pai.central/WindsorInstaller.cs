using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using pl.lodz.p.ftims.edu.pai.central.dal;
using pl.lodz.p.ftims.edu.pai.central.BusinessService;

namespace pl.lodz.p.ftims.edu.pai.central
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                           Component.For<IUnitOfWork, EfUnitOfWork>(),
                           Component.For<IManagement, Management>(),
                           Component.For<IGeneralManagement, GeneralManagement>()
                );
        }
    }
   
}