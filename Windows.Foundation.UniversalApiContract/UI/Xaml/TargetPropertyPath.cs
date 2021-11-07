// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TargetPropertyPath
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the path to a property on a target element.</summary>
  [WebHostHidden]
  [Activatable(typeof (ITargetPropertyPathFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class TargetPropertyPath : ITargetPropertyPath
  {
    /// <summary>Initializes a new instance of the TargetPropertyPath class with the specified target property.</summary>
    /// <param name="targetProperty">The target property.</param>
    [MethodImpl]
    public extern TargetPropertyPath(DependencyProperty targetProperty);

    /// <summary>Initializes a new instance of the TargetPropertyPath class.</summary>
    [MethodImpl]
    public extern TargetPropertyPath();

    /// <summary>Gets or sets the path to the property on the target element.</summary>
    /// <returns>The path to the property on the target element.</returns>
    public extern PropertyPath Path { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that contains the property described by Path.</summary>
    /// <returns>The object that contains the property described by Path.</returns>
    public extern object Target { [MethodImpl] get; [MethodImpl] set; }
  }
}
