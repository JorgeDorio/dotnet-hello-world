using ola_mundo;
using System.IO;
using System;
using Xunit;
using FluentAssertions;

namespace ola_mundo.Test;

public class OlaMundoTest
{
    [Theory(DisplayName = "Deve exibir Olá, Mundo!")]
    [InlineData("Olá, Mundo!")]
    public void TestOlaMundo(string Expected)
    {        
        var result = HelloWorld.Greet();
        result.Should().Be(Expected);
    }
}