using System.ComponentModel.DataAnnotations;

namespace Catalog.Service;

// Data Transfer Objects.............

public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedData);

public record CreateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);

public record UpdateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);