

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using OSIRISGenNHibernate.Exceptions;

using OSIRISGenNHibernate.EN.OSIRIS;
using OSIRISGenNHibernate.CAD.OSIRIS;


namespace OSIRISGenNHibernate.CEN.OSIRIS
{
/*
 *      Definition of the class CriticaCEN
 *
 */
public partial class CriticaCEN
{
private ICriticaCAD _ICriticaCAD;

public CriticaCEN()
{
        this._ICriticaCAD = new CriticaCAD ();
}

public CriticaCEN(ICriticaCAD _ICriticaCAD)
{
        this._ICriticaCAD = _ICriticaCAD;
}

public ICriticaCAD get_ICriticaCAD ()
{
        return this._ICriticaCAD;
}

public int New_ ()
{
        CriticaEN criticaEN = null;
        int oid;

        //Initialized CriticaEN
        criticaEN = new CriticaEN ();
        //Call to CriticaCAD

        oid = _ICriticaCAD.New_ (criticaEN);
        return oid;
}

public void Modify (int p_Critica_OID)
{
        CriticaEN criticaEN = null;

        //Initialized CriticaEN
        criticaEN = new CriticaEN ();
        criticaEN.Id = p_Critica_OID;
        //Call to CriticaCAD

        _ICriticaCAD.Modify (criticaEN);
}

public void Destroy (int id
                     )
{
        _ICriticaCAD.Destroy (id);
}
}
}
