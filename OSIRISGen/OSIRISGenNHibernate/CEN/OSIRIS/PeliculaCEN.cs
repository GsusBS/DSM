

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
 *      Definition of the class PeliculaCEN
 *
 */
public partial class PeliculaCEN
{
private IPeliculaCAD _IPeliculaCAD;

public PeliculaCEN()
{
        this._IPeliculaCAD = new PeliculaCAD ();
}

public PeliculaCEN(IPeliculaCAD _IPeliculaCAD)
{
        this._IPeliculaCAD = _IPeliculaCAD;
}

public IPeliculaCAD get_IPeliculaCAD ()
{
        return this._IPeliculaCAD;
}

public int New_ (string p_nombre)
{
        PeliculaEN peliculaEN = null;
        int oid;

        //Initialized PeliculaEN
        peliculaEN = new PeliculaEN ();
        peliculaEN.Nombre = p_nombre;

        //Call to PeliculaCAD

        oid = _IPeliculaCAD.New_ (peliculaEN);
        return oid;
}

public void Modify (int p_Pelicula_OID, string p_nombre)
{
        PeliculaEN peliculaEN = null;

        //Initialized PeliculaEN
        peliculaEN = new PeliculaEN ();
        peliculaEN.Id = p_Pelicula_OID;
        peliculaEN.Nombre = p_nombre;
        //Call to PeliculaCAD

        _IPeliculaCAD.Modify (peliculaEN);
}

public void Destroy (int id
                     )
{
        _IPeliculaCAD.Destroy (id);
}
}
}
