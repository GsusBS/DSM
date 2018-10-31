
using System;
// Definición clase BibliotecaEN
namespace OSIRISGenNHibernate.EN.OSIRIS
{
public partial class BibliotecaEN
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





public BibliotecaEN()
{
        cliente = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.ClienteEN>();
        producto = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN>();
}



public BibliotecaEN(int id, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ClienteEN> cliente, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> producto
                    )
{
        this.init (Id, cliente, producto);
}


public BibliotecaEN(BibliotecaEN biblioteca)
{
        this.init (Id, biblioteca.Cliente, biblioteca.Producto);
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
        BibliotecaEN t = obj as BibliotecaEN;
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
