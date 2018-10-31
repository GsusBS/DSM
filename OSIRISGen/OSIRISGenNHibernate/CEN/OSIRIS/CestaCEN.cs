

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
 *      Definition of the class CestaCEN
 *
 */
public partial class CestaCEN
{
private ICestaCAD _ICestaCAD;

public CestaCEN()
{
        this._ICestaCAD = new CestaCAD ();
}

public CestaCEN(ICestaCAD _ICestaCAD)
{
        this._ICestaCAD = _ICestaCAD;
}

public ICestaCAD get_ICestaCAD ()
{
        return this._ICestaCAD;
}

public int New_ ()
{
        CestaEN cestaEN = null;
        int oid;

        //Initialized CestaEN
        cestaEN = new CestaEN ();
        //Call to CestaCAD

        oid = _ICestaCAD.New_ (cestaEN);
        return oid;
}

public void Modify (int p_Cesta_OID)
{
        CestaEN cestaEN = null;

        //Initialized CestaEN
        cestaEN = new CestaEN ();
        cestaEN.Id = p_Cesta_OID;
        //Call to CestaCAD

        _ICestaCAD.Modify (cestaEN);
}

public void Destroy (int id
                     )
{
        _ICestaCAD.Destroy (id);
}
}
}
