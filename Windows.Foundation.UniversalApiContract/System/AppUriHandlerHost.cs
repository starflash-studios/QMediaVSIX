// Decompiled with JetBrains decompiler
// Type: Windows.System.AppUriHandlerHost
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>An object representation of the Host field in an AppUriHandler registration. These are used in conjunction with AppUriHandlerRegistration.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IAppUriHandlerHostFactory), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Activatable(458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class AppUriHandlerHost : IAppUriHandlerHost, IAppUriHandlerHost2
  {
    /// <summary>Constructor for AppUriHandlerHost which sets the name as well.</summary>
    /// <param name="name">A website hostname.</param>
    [MethodImpl]
    public extern AppUriHandlerHost(string name);

    /// <summary>Default constructor for AppUriHandlerHost.</summary>
    [MethodImpl]
    public extern AppUriHandlerHost();

    /// <summary>A website hostname.</summary>
    /// <returns>A website hostname.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
