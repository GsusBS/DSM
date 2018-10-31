
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
public partial class ClienteCP : BasicCP
{
public ClienteCP() : base ()
{
}

public ClienteCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
