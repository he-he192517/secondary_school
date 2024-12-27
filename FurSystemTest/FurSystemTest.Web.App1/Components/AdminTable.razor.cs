using System.Diagnostics.CodeAnalysis;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;

namespace FurSystemTest.Web.App1.Components;

[CascadingTypeParameter(nameof(TItem))]
public partial class AdminTable<TItem> where TItem : class, new()
{
    [Parameter]
    public IEnumerable<TItem>? Items { get; set; }

    [NotNull]
    [Parameter]
    public RenderFragment<TItem>? TableColumns { get; set; }

    [Parameter]
    public Func<TItem, ItemChangedType, Task<bool>>? OnSaveAsync { get; set; }

    [Parameter]
    public Func<IEnumerable<TItem>, Task<bool>>? OnDeleteAsync { get; set; }

    [Parameter]
    public bool IsTree { get; set; }

    [Parameter]
    public Func<IEnumerable<TItem>, Task<IEnumerable<TableTreeNode<TItem>>>>? TreeNodeConverter { get; set; }

    [Parameter]
    public Func<TItem,bool>? ShowExtendEditButtonCallback { get; set; }

    [Parameter]
    public Func<TItem,bool>? ShowExtendDeleteButtonCallback { get; set; }

    [Parameter]
    public RenderFragment<TItem>? BeforeRowButtonTemplate { get; set; }

    [Parameter]
    public Func<QueryPageOptions, Task<QueryData<TItem>>>? OnQueryAsync { get; set; }

    [NotNull]
    private Table<TItem>? Instance { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task QueryAsync() => Instance.QueryAsync();

    [Parameter]
    public RenderFragment<TItem>? RowButtonTemplate { get; set; }
}
