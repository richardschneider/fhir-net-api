﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Fhir.Model;
using Hl7.Fhir.Support;
using Hl7.Fhir.Introspection;

namespace Hl7.Fhir.Test.Inspection
{
    [TestClass]
#if PORTABLE45
	public class PortableClassMappingTest
#else
	public class ClassMappingTest
#endif
    {
        [TestMethod]
        public void TestResourceMappingCreation()
        {
            var mapping = ClassMapping.Create(typeof(Road));
            Assert.IsTrue(mapping.IsResource);
            Assert.AreEqual("Road", mapping.Name);
            Assert.AreEqual(typeof(Road), mapping.NativeType);
            Assert.IsNull(mapping.Profile);

            mapping = ClassMapping.Create(typeof(Way));
            Assert.IsTrue(mapping.IsResource);
            Assert.AreEqual("Way", mapping.Name);
            Assert.AreEqual(typeof(Way), mapping.NativeType);
            Assert.IsNull(mapping.Profile);

            mapping = ClassMapping.Create(typeof(ProfiledWay));
            Assert.IsTrue(mapping.IsResource);
            Assert.AreEqual("Way", mapping.Name);
            Assert.AreEqual(typeof(ProfiledWay), mapping.NativeType);
            Assert.IsNotNull(mapping.Profile);

            mapping = ClassMapping.Create(typeof(NewStreet));
            Assert.IsTrue(mapping.IsResource);
            Assert.AreEqual("Street", mapping.Name);
            Assert.AreEqual(typeof(NewStreet), mapping.NativeType);
            Assert.IsNull(mapping.Profile);
        }


        [TestMethod]
        public void TestDatatypeMappingCreation()
        {
            var mapping = ClassMapping.Create(typeof(AnimalName));
            Assert.IsFalse(mapping.IsResource);
            Assert.AreEqual("AnimalName", mapping.Name);
            Assert.AreEqual(typeof(AnimalName), mapping.NativeType);
            Assert.IsNull(mapping.Profile);

            mapping = ClassMapping.Create(typeof(NewAnimalName));
            Assert.IsFalse(mapping.IsResource);
            Assert.AreEqual("AnimalName", mapping.Name);
            Assert.AreEqual(typeof(NewAnimalName), mapping.NativeType);
            Assert.IsNull(mapping.Profile);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMixedDataTypeDetection()
        {
            var mapping = ClassMapping.Create(typeof(ComplexNumber));

            // cannot have a datatype with a profile....
        }

   }


    /*
     * Resource classes for tests 
     */
    [FhirType(IsResource=true)]
    public class Road {}

    [FhirType]
    public class Way : Resource { }
    
    [FhirType("Way", Profile="http://nu.nl/profile#street")]
    public class ProfiledWay : Resource {}

    [FhirType("Street", IsResource=true)]
    public class NewStreet { }


    /* 
     * Datatype classes for tests
     */
    [FhirType]
    public class AnimalName { }

    [FhirType("AnimalName")]
    public class NewAnimalName : AnimalName { }

    [FhirType("Complex", Profile = "http://hl7.org/profiles/test")]
    public class ComplexNumber { }
}
