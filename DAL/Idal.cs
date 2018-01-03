using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface Idal
    {
        void delNanny(Nanny nanny);
        void addNanny(Nanny nanny);
        void updateNanny(Nanny nanny);

        void addMom(Mother mom);
        void delMom(Mother mom);
        void updateMom(Mother mom);

        void addChild(Child child);
        void delChild(Child child);
        void updateChild(Child child);

        void addContract(Contract cont);
        void delContract(Contract cont);
        void updateContract(Contract cont);

        List<Nanny> getNannys();
        List<Mother> getMoms();
        List<Child> getChildren();
        List<Contract> getContracts();
    }
}
