// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationStructureChangeType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Defines the types of change in the Microsoft UI Automation tree structure.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AutomationStructureChangeType
  {
    /// <summary>A child has been added to the current node.</summary>
    ChildAdded,
    /// <summary>A child has been removed from the current node.</summary>
    ChildRemoved,
    /// <summary>One or more children of the current node have been invalidated.</summary>
    ChildrenInvalidated,
    /// <summary>Children have been bulk added to the current node.</summary>
    ChildrenBulkAdded,
    /// <summary>Children have been bulk removed from the current node.</summary>
    ChildrenBulkRemoved,
    /// <summary>The children of the current node have been reordered.</summary>
    ChildrenReordered,
  }
}
