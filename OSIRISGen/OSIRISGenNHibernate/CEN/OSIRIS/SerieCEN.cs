

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
 *      Definition of the class SerieCEN
 *
 */
public partial class SerieCEN
{
private ISerieCAD _ISerieCAD;

public SerieCEN()
{
        this._ISerieCAD = new SerieCAD ();
}

public SerieCEN(ISerieCAD _ISerieCAD)
{
        this._ISerieCAD = _ISerieCAD;
}

public ISerieCAD get_ISerieCAD ()
{
        return this._ISerieCAD;
}

public int New_ (string p_nombre)
{
        SerieEN serieEN = null;
        int oid;

        //Initialized SerieEN
        serieEN = new SerieEN ();
        serieEN.Nombre = p_nombre;

        //Call to SerieCAD

        oid = _ISerieCAD.New_ (serieEN);
        return oid;
}

public void Modify (int p_Serie_OID, string p_nombre)
{
        SerieEN serieEN = null;

        //Initialized SerieEN
        serieEN = new SerieEN ();
        serieEN.Id = p_Serie_OID;
        serieEN.Nombre = p_nombre;
        //Call to SerieCAD

        _ISerieCAD.Modify (serieEN);
}

public void Destroy (int id
                     )
{
        _ISerieCAD.Destroy (id);
}
}
}
