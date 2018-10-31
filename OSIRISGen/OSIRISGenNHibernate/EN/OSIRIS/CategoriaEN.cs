
using System;
// Definición clase CategoriaEN
namespace OSIRISGenNHibernate.EN.OSIRIS
{
public partial class CategoriaEN
{
/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> producto;



/**
 *	Atributo id
 */
private int id;






public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public CategoriaEN()
{
        producto = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN>();
}



public CategoriaEN(int id, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> producto
                   )
{
        this.init (Id, producto);
}


public CategoriaEN(CategoriaEN categoria)
{
        this.init (Id, categoria.Producto);
}

private void init (int id
                   , System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> producto)
{
        this.Id = id;


        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CategoriaEN t = obj as CategoriaEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
