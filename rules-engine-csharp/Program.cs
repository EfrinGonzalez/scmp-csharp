// See https://aka.ms/new-console-template for more information
using rules_engine_csharp.factory;
using rules_engine_csharp.implementations;
using rules_engine_csharp.interfaces;
using rules_engine_csharp.models;
using rules_engine_csharp.services;

Console.WriteLine("Welcome to the Factory Engine!");


Payment paymentPhysical = new Payment(1, rules_engine_csharp.enums.Type.PHYSICAL_PRODUCT, null);
PhysicalRulesImpl instancePhysical = (PhysicalRulesImpl)PaymentFactory.create(paymentPhysical);
PhysicalProductService service = new PhysicalProductService(instancePhysical);
service.executePhysicalRules(paymentPhysical);
service.calculateTotal(paymentPhysical);

//IEmailRules notificator = new EmailRulesImpl();

Payment paymentDigitalActivation = new Payment(2, rules_engine_csharp.enums.Type.MEMBERSHIP_ACTIVATION, null);
MembershipRulesImpl digitalInstance = (MembershipRulesImpl)PaymentFactory.create(paymentDigitalActivation);
MembershipService service2 = new MembershipService(digitalInstance, new EmailRulesImpl());
service2.executeCreationRules(paymentDigitalActivation);





/*Payment paymentDigitalUpgrade = new Payment(3, rules_engine_csharp.enums.Type.MEMBERSHIP_UPGRADE, null);
PaymentFactory.create(paymentDigitalUpgrade);*/
