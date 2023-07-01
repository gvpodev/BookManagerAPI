using BookManager.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace BookManagerAPI.UnitTests.BookManagerAPI.App.Controllers;

public class BookControllerTest
{
    private readonly BookController _controller;

    public BookControllerTest()
    {
        _controller = new BookController();
    }

    [Fact]
    public void When_add_Should_return_ok()
    {
        var response = _controller.Create();

        response.Should().BeAssignableTo<OkResult>();
    }
    
    [Fact]
    public void When_update_Should_return_ok()
    {
        var response = _controller.Update();

        response.Should().BeAssignableTo<OkResult>();
    }
    
    [Fact]
    public void When_delete_Should_return_ok()
    {
        var response = _controller.Delete();

        response.Should().BeAssignableTo<OkResult>();
    }
    
    [Fact]
    public void When_find_all_Should_return_ok()
    {
        var response = _controller.FindAll();

        response.Should().BeAssignableTo<OkResult>();
    }
    
    [Fact]
    public void When_find_Should_return_ok()
    {
        var response = _controller.Find();

        response.Should().BeAssignableTo<OkResult>();
    }
}