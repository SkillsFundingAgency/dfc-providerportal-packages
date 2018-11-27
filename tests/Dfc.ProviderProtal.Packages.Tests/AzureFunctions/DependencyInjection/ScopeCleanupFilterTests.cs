using Dfc.ProviderPortal.Packages;
using System;
using System.Collections.Generic;
using Xunit;
using Microsoft.Azure.WebJobs.Host;
using Dfc.ProviderPortal.Packages.AzureFunctions.DependencyInjection;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Microsoft.Extensions.Logging;

namespace Dfc.ProviderProtal.Packages.Tests.AzureFunctions.DependencyInjection
{
    public class ScopeCleanupFilterTests
    {
        [Fact]
        public void OnExecutingAsync_WithFunctionExecutingContextAsNull_ReturnsCompletedTask()
        {
            // arrange
            FunctionExecutingContext functionExecutingContext = null;
            CancellationToken cancellationToken = new CancellationToken();
            var expected = Task.CompletedTask;

            var actual = new ScopeCleanupFilter().OnExecutingAsync(functionExecutingContext, cancellationToken);

            // act & assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OnExecutingAsync_WithFunctionExecutingContextAsNotNull_ReturnsCompletedTask()
        {
            // arrange
            var arguments = new Dictionary<string, object>();
            var properties = new Dictionary<string, object>();
            var functionInstanceId = Guid.NewGuid();
            var functionName = "SomeName";
            var mockLogger = new Mock<ILogger>();

            // act
            FunctionExecutingContext functionExecutingContext =  new FunctionExecutingContext(
                arguments,
                properties,
                functionInstanceId,
                functionName,
                mockLogger.Object);
            CancellationToken cancellationToken = new CancellationToken();
            var expected = Task.CompletedTask;

            var actual = new ScopeCleanupFilter().OnExecutingAsync(functionExecutingContext, cancellationToken);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OnExecutedAsync_WithFunctionExecutedContextAsNull_ThrowsArgumentNullException()
        {
            // arrange
            FunctionExecutedContext functionExecutedContext = null;
            CancellationToken cancellationToken = new CancellationToken();

            // act & assert
            Assert.ThrowsAsync<ArgumentNullException>(() => new ScopeCleanupFilter().OnExecutedAsync(functionExecutedContext, cancellationToken));
        }

        [Fact]
        public void OnExecutedAsync_WithFunctionExecutedContextAsNotNull_ReturnsCompletedTask()
        {
            // arrange
            var arguments = new Dictionary<string, object>();
            var properties = new Dictionary<string, object>();
            var functionInstanceId = Guid.NewGuid();
            var functionName = "SomeName";
            var mockLogger = new Mock<ILogger>();

            // act
            FunctionExecutedContext functionExecutedContext = new FunctionExecutedContext(
                arguments,
                properties,
                functionInstanceId,
                functionName,
                mockLogger.Object,
                new Microsoft.Azure.WebJobs.Host.Executors.FunctionResult(true));
            CancellationToken cancellationToken = new CancellationToken();
            var expected = Task.CompletedTask;

            var actual = new ScopeCleanupFilter().OnExecutedAsync(functionExecutedContext, cancellationToken);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OnExceptionAsync_WithFunctionExceptionContextAsNull_ThrowsArgumentNullException()
        {
            // arrange
            FunctionExceptionContext functionExceptionContext = null;
            CancellationToken cancellationToken = new CancellationToken();

            // act & assert
            Assert.ThrowsAsync<ArgumentNullException>(() => new ScopeCleanupFilter().OnExceptionAsync(functionExceptionContext, cancellationToken));
        }

        [Fact]
        public void OnExceptionAsync_WithFunctionExceptionContextAsNotNull_ReturnsCompletedTask()
        {
            // arrange
            var arguments = new Dictionary<string, object>();
            var properties = new Dictionary<string, object>();
            var functionInstanceId = Guid.NewGuid();
            var functionName = "SomeName";
            var mockLogger = new Mock<ILogger>();

            // act
            FunctionExecutedContext functionExecutedContext = new FunctionExecutedContext(
                arguments,
                properties,
                functionInstanceId,
                functionName,
                mockLogger.Object,
                new Microsoft.Azure.WebJobs.Host.Executors.FunctionResult(true));
            CancellationToken cancellationToken = new CancellationToken();
            var expected = Task.CompletedTask;

            var actual = new ScopeCleanupFilter().OnExecutedAsync(functionExecutedContext, cancellationToken);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
