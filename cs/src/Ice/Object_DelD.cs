// **********************************************************************
//
// Copyright (c) 2003
// ZeroC, Inc.
// Billerica, MA, USA
//
// All Rights Reserved.
//
// Ice is free software; you can redistribute it and/or modify it under
// the terms of the GNU General Public License version 2 as published by
// the Free Software Foundation.
//
// **********************************************************************
namespace Ice
{
	
    using System.Collections;
    using System.Diagnostics;

    public class Object_DelD : Object_Del
    {
	public virtual bool ice_isA(string __id, Ice.Context __context)
	{
	    Current __current = new Current();
	    __initCurrent(__current, "ice_isA", OperationMode.Nonmutating, __context);
	    while(true)
	    {
		IceInternal.Direct __direct = new IceInternal.Direct(__current);
		try
		{
		    return __direct.facetServant().ice_isA(__id, __current);
		}
		finally
		{
		    __direct.destroy();
		}
	    }
	}
	
	public virtual void ice_ping(Ice.Context __context)
	{
	    Current __current = new Current();
	    __initCurrent(__current, "ice_ping", OperationMode.Nonmutating, __context);
	    while(true)
	    {
		IceInternal.Direct __direct = new IceInternal.Direct(__current);
		try
		{
		    __direct.facetServant().ice_ping(__current);
		    return;
		}
		finally
		{
		    __direct.destroy();
		}
	    }
	}
	
	public virtual StringSeq ice_ids(Ice.Context __context)
	{
	    Current __current = new Current();
	    __initCurrent(__current, "ice_ids", OperationMode.Nonmutating, __context);
	    while(true)
	    {
		IceInternal.Direct __direct = new IceInternal.Direct(__current);
		try
		{
		    return __direct.facetServant().ice_ids(__current);
		}
		finally
		{
		    __direct.destroy();
		}
	    }
	}
	
	public virtual string ice_id(Ice.Context __context)
	{
	    Current __current = new Current();
	    __initCurrent(__current, "ice_id", OperationMode.Nonmutating, __context);
	    while(true)
	    {
		IceInternal.Direct __direct = new IceInternal.Direct(__current);
		try
		{
		    return __direct.facetServant().ice_id(__current);
		}
		finally
		{
		    __direct.destroy();
		}
	    }
	}
	
	public virtual Ice.FacetPath ice_facets(Ice.Context __context)
	{
	    Current __current = new Current();
	    __initCurrent(__current, "ice_facets", OperationMode.Nonmutating, __context);
	    while(true)
	    {
		IceInternal.Direct __direct = new IceInternal.Direct(__current);
		try
		{
		    return __direct.facetServant().ice_facets(__current);
		}
		finally
		{
		    __direct.destroy();
		}
	    }
	}
	
	public virtual bool ice_invoke(string operation, Ice.OperationMode mode, Ice.ByteSeq inParams,
	                               out Ice.ByteSeq outParams, Ice.Context context)
	{
	    throw new CollocationOptimizationException();
	}
	
	//
	// Only for use by ObjectPrx.
	//
	internal void __copyFrom(Object_DelD from)
	{
	    //
	    // No need to synchronize "from", as the delegate is immutable
	    // after creation.
	    //
	    
	    //
	    // No need to synchronize, as this operation is only called
	    // upon initialization.
	    //
	    
	    Debug.Assert(__reference == null);
	    Debug.Assert(__adapter == null);
	    
	    __reference = from.__reference;
	    __adapter = from.__adapter;
	}
	
	protected internal IceInternal.Reference __reference;
	protected internal Ice.ObjectAdapter __adapter;
	
	protected internal void __initCurrent(Current current, string op, Ice.OperationMode mode, Ice.Context context)
	{
	    current.adapter = __adapter;
	    current.id = __reference.identity;
	    current.facet = __reference.facet;
	    current.operation = op;
	    current.mode = mode;
	    current.ctx = context;
	}
	
	public virtual void setup(IceInternal.Reference rf, Ice.ObjectAdapter adapter)
	{
	    //
	    // No need to synchronize, as this operation is only called
	    // upon initialization.
	    //
	    
	    Debug.Assert(__reference == null);
	    Debug.Assert(__adapter == null);
	    
	    __reference = rf;
	    __adapter = adapter;
	}
    }

}
