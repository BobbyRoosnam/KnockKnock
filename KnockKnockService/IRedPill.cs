﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KnockKnockService
{
    using System.Runtime.Serialization;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }



    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://KnockKnock.readify.net", ConfigurationName = "KnockKnockService.IRedPill")]
    public interface IRedPill
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
        System.Guid WhatIsYourToken();

        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentOutOfRangeException), Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberArgumentOutOfRangeException" +
            "Fault", Name = "ArgumentOutOfRangeException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        long FibonacciNumber(long n);

        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction = "http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentNullException), Action = "http://KnockKnock.readify.net/IRedPill/ReverseWordsArgumentNullExceptionFault", Name = "ArgumentNullException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        string ReverseWords(string s);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRedPillChannel : IRedPill, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RedPillClient : System.ServiceModel.ClientBase<IRedPill>, IRedPill
    {

        public RedPillClient()
        {
        }

        public RedPillClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public RedPillClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public RedPillClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public RedPillClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public System.Guid WhatIsYourToken()
        {
            return base.Channel.WhatIsYourToken();
        }

        public long FibonacciNumber(long n)
        {
            return base.Channel.FibonacciNumber(n);
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return base.Channel.WhatShapeIsThis(a, b, c);
        }

        public string ReverseWords(string s)
        {
            return base.Channel.ReverseWords(s);
        }
    }
}