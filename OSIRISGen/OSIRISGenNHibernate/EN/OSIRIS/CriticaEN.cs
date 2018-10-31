
using System;
// Definición clase CriticaEN
namespace OSIRISGenNHibernate.EN.OSIRIS
{
public partial class CriticaEN
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





public CriticaEN()
{
        producto = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN>();
}



public CriticaEN(int id, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> producto
                 )
{
        this.init (Id, producto);
}


public CriticaEN(CriticaEN critica)
{
        this.init (Id, critica.Producto);
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
        CriticaEN t = obj as CriticaEN;
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
