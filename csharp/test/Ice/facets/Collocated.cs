// **********************************************************************
//
// Copyright (c) 2003-2018 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************

using System;
using System.Reflection;

[assembly: CLSCompliant(true)]

[assembly: AssemblyTitle("IceTest")]
[assembly: AssemblyDescription("Ice test")]
[assembly: AssemblyCompany("ZeroC, Inc.")]

public class Collocated : Test.TestHelper
{
    public override void run(string[] args)
    {
        using(var communicator = initialize(ref args))
        {
            communicator.getProperties().setProperty("TestAdapter.Endpoints", getTestEndpoint(0));
            Ice.ObjectAdapter adapter = communicator.createObjectAdapter("TestAdapter");
            Ice.Object d = new DI();
            adapter.add(d, Ice.Util.stringToIdentity("d"));
            adapter.addFacet(d, Ice.Util.stringToIdentity("d"), "facetABCD");
            Ice.Object f = new FI();
            adapter.addFacet(f, Ice.Util.stringToIdentity("d"), "facetEF");
            Ice.Object h = new HI(communicator);
            adapter.addFacet(h, Ice.Util.stringToIdentity("d"), "facetGH");
            AllTests.allTests(this);
        }
    }

    public static int Main(string[] args)
    {
        return Test.TestDriver.runTest<Collocated>(args);
    }
}
