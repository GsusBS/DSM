
using System;
// Definición clase ClienteEN
namespace OSIRISGenNHibernate.EN.OSIRIS
{
public partial class ClienteEN                                                                      : OSIRISGenNHibernate.EN.OSIRIS.UsuarioEN


{
/**
 *	Atributo cesta
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CestaEN> cesta;



/**
 *	Atributo biblioteca
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN> biblioteca;



/**
 *	Atributo attribute
 */
private string attribute;






public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CestaEN> Cesta {
        get { return cesta; } set { cesta = value;  }
}



public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN> Biblioteca {
        get { return biblioteca; } set { biblioteca = value;  }
}



public virtual string Attribute {
        get { return attribute; } set { attribute = value;  }
}





public ClienteEN() : base ()
{
        cesta = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.CestaEN>();
        biblioteca = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN>();
}



public ClienteEN(int id, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CestaEN> cesta, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN> biblioteca, string attribute

                 )
{
        this.init (Id, cesta, biblioteca, attribute);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (Id, cliente.Cesta, cliente.Biblioteca, cliente.Attribute);
}

private void init (int id
                   , System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CestaEN> cesta, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN> biblioteca, string attribute)
{
        this.Id = id;


        this.Cesta = cesta;

        this.Biblioteca = biblioteca;

        this.Attribute = attribute;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClienteEN t = obj as ClienteEN;
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
