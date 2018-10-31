

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
 *      Definition of the class CategoriaCEN
 *
 */
public partial class CategoriaCEN
{
private ICategoriaCAD _ICategoriaCAD;

public CategoriaCEN()
{
        this._ICategoriaCAD = new CategoriaCAD ();
}

public CategoriaCEN(ICategoriaCAD _ICategoriaCAD)
{
        this._ICategoriaCAD = _ICategoriaCAD;
}

public ICategoriaCAD get_ICategoriaCAD ()
{
        return this._ICategoriaCAD;
}

public int New_ ()
{
        CategoriaEN categoriaEN = null;
        int oid;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        //Call to CategoriaCAD

        oid = _ICategoriaCAD.New_ (categoriaEN);
        return oid;
}

public void Modify (int p_Categoria_OID)
{
        CategoriaEN categoriaEN = null;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Id = p_Categoria_OID;
        //Call to CategoriaCAD

        _ICategoriaCAD.Modify (categoriaEN);
}

public void Destroy (int id
                     )
{
        _ICategoriaCAD.Destroy (id);
}
}
}
