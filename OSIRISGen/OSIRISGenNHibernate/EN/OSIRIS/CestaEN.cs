
using System;
// Definición clase CestaEN
namespace OSIRISGenNHibernate.EN.OSIRIS
{
public partial class CestaEN
{
/**
 *	Atributo cliente
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ClienteEN> cliente;



/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> producto;



/**
 *	Atributo id
 */
private int id;






public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ClienteEN> Cliente {
        get { return cliente; } set { cliente = value;  }
}



public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public CestaEN()
{
        cliente = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.ClienteEN>();
        producto = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN>();
}



public CestaEN(int id, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ClienteEN> cliente, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> producto
               )
{
        this.init (Id, cliente, producto);
}


public CestaEN(CestaEN cesta)
{
        this.init (Id, cesta.Cliente, cesta.Producto);
}

private void init (int id
                   , System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ClienteEN> cliente, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> producto)
{
        this.Id = id;


        this.Cliente = cliente;

        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CestaEN t = obj as CestaEN;
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
