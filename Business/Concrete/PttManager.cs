using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager : ISupplierService
{
    //Sonarqube
    //gercek hayatta interface
    private IApplicantService _applicantService;
    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }
    public void GİveMask(Person person)
    {
        //PttManager pttManager = new PttManager(new ForeignerManager);
        if (_applicantService.IsExist(person))
        {
            Console.WriteLine("Give Mask to this person: " + person.FirstName);
        }
        else
        {
            Console.WriteLine("Can Not give a mask to this person: "+ person.FirstName);
        }
    }
}
