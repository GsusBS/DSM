

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
 *      Definition of the class BibliotecaCEN
 *
 */
public partial class BibliotecaCEN
{
private IBibliotecaCAD _IBibliotecaCAD;

public BibliotecaCEN()
{
        this._IBibliotecaCAD = new BibliotecaCAD ();
}

public BibliotecaCEN(IBibliotecaCAD _IBibliotecaCAD)
{
        this._IBibliotecaCAD = _IBibliotecaCAD;
}

public IBibliotecaCAD get_IBibliotecaCAD ()
{
        return this._IBibliotecaCAD;
}

public int New_ ()
{
        BibliotecaEN bibliotecaEN = null;
        int oid;

        //Initialized BibliotecaEN
        bibliotecaEN = new BibliotecaEN ();
        //Call to BibliotecaCAD

        oid = _IBibliotecaCAD.New_ (bibliotecaEN);
        return oid;
}

public void Modify (int p_Biblioteca_OID)
{
        BibliotecaEN bibliotecaEN = null;

        //Initialized BibliotecaEN
        bibliotecaEN = new BibliotecaEN ();
        bibliotecaEN.Id = p_Biblioteca_OID;
        //Call to BibliotecaCAD

        _IBibliotecaCAD.Modify (bibliotecaEN);
}

public void Destroy (int id
                     )
{
        _IBibliotecaCAD.Destroy (id);
}
}
}
