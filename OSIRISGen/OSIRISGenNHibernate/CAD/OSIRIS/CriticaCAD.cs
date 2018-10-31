
using System;
using System.Text;
using OSIRISGenNHibernate.CEN.OSIRIS;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using OSIRISGenNHibernate.EN.OSIRIS;
using OSIRISGenNHibernate.Exceptions;


/*
 * Clase Critica:
 *
 */

namespace OSIRISGenNHibernate.CAD.OSIRIS
{
public partial class CriticaCAD : BasicCAD, ICriticaCAD
{
public CriticaCAD() : base ()
{
}

public CriticaCAD(ISession sessionAux) : base (sessionAux)
{
}



public CriticaEN ReadOIDDefault (int id
                                 )
{
        CriticaEN criticaEN = null;

        try
        {
                SessionInitializeTransaction ();
                criticaEN = (CriticaEN)session.Get (typeof(CriticaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return criticaEN;
}

public System.Collections.Generic.IList<CriticaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CriticaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CriticaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CriticaEN>();
                        else
                                result = session.CreateCriteria (typeof(CriticaEN)).List<CriticaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CriticaEN critica)
{
        try
        {
                SessionInitializeTransaction ();
                CriticaEN criticaEN = (CriticaEN)session.Load (typeof(CriticaEN), critica.Id);

                session.Update (criticaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CriticaEN critica)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (critica);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return critica.Id;
}

public void Modify (CriticaEN critica)
{
        try
        {
                SessionInitializeTransaction ();
                CriticaEN criticaEN = (CriticaEN)session.Load (typeof(CriticaEN), critica.Id);
                session.Update (criticaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                CriticaEN criticaEN = (CriticaEN)session.Load (typeof(CriticaEN), id);
                session.Delete (criticaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
