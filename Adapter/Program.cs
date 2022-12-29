using Adapter;

ITarget target = new Adaptaa(new Adaptee());
Client client = new Client(target);
client.Request();