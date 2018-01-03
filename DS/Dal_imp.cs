using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    class Dal_imp : DAL.Idal
    {
        public void addChild(Child child)
        {
            DataSource.childList.Add(child);
        }

        public void addContract(Contract cont)
        {
            DataSource.contractList.Add(cont);
        }

        public void addMom(Mother mom)
        {
            DataSource.motherList.Add(mom);
        }

        public void addNanny(Nanny nanny)
        {
            DataSource.nannyList.Add(nanny);
        }

        public void delChild(Child child)
        {
            DataSource.childList.Remove(child);
        }

        public void delContract(Contract cont)
        {
            DataSource.contractList.Remove(cont);
        }

        public void delMom(Mother mom)
        {
            DataSource.motherList.Remove(mom);
        }

        public void delNanny(Nanny nanny)
        {
            DataSource.nannyList.Remove(nanny);
        }

        public List<Child> getChildren()
        {
            return DataSource.childList;
        }

        public List<Contract> getContracts()
        {
            return DataSource.contractList;
        }

        public List<Mother> getMoms()
        {
            return DataSource.motherList;
        }

        public List<Nanny> getNannys()
        {
            return DataSource.nannyList;
        }

        public void updateChild(Child child)
        {
            int index = DataSource.childList.FindIndex(x => x.childID == child.childID);
            if (index != -1)
                DataSource.childList[index] = child;
        }

        public void updateContract(Contract cont)
        {
            int index = DataSource.contractList.FindIndex(x => x.contractID == cont.contractID);
            if (index != -1)
                DataSource.contractList[index] = cont;
        }

        public void updateMom(Mother mom)
        {
            int index = DataSource.motherList.FindIndex(x => x.momID == mom.momID);
            if (index != -1)
                DataSource.motherList[index] = mom;
        }

        public void updateNanny(Nanny nanny)
        {
            int index = DataSource.nannyList.FindIndex(x => x.nannyID == nanny.nannyID);
            if (index != -1)
                DataSource.nannyList[index] = nanny;
        }
    }
}
