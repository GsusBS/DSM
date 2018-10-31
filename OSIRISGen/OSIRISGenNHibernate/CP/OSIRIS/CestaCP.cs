
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using OSIRISGenNHibernate.Exceptions;
using OSIRISGenNHibernate.EN.OSIRIS;
using OSIRISGenNHibernate.CAD.OSIRIS;
using OSIRISGenNHibernate.CEN.OSIRIS;



namespace OSIRISGenNHibernate.CP.OSIRIS
{
public partial class CestaCP : BasicCP
{
public CestaCP() : base ()
{
}

public CestaCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
