// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
    using Google.Ads.GoogleAds.V0.Services;
    using apis = Google.Ads.GoogleAds.V0.Services;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using NUnit.Framework;

    /// <summary>Generated unit tests</summary>
    public class GeneratedCustomerServiceClientTest
    {
        [Test]
        public void GetCustomer()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            GetCustomerRequest expectedRequest = new GetCustomerRequest
            {
                ResourceName = new CustomerName("[CUSTOMER]").ToString(),
            };
            Customer expectedResponse = new Customer
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomer(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerName("[CUSTOMER]").ToString();
            Customer response = client.GetCustomer(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerAsync()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            GetCustomerRequest expectedRequest = new GetCustomerRequest
            {
                ResourceName = new CustomerName("[CUSTOMER]").ToString(),
            };
            Customer expectedResponse = new Customer
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Customer>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerName("[CUSTOMER]").ToString();
            Customer response = await client.GetCustomerAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomer2()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            GetCustomerRequest request = new GetCustomerRequest
            {
                ResourceName = new CustomerName("[CUSTOMER]").ToString(),
            };
            Customer expectedResponse = new Customer
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomer(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            Customer response = client.GetCustomer(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerAsync2()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            GetCustomerRequest request = new GetCustomerRequest
            {
                ResourceName = new CustomerName("[CUSTOMER]").ToString(),
            };
            Customer expectedResponse = new Customer
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Customer>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            Customer response = await client.GetCustomerAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
