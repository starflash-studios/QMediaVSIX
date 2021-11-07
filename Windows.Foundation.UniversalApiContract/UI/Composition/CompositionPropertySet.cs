// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionPropertySet
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Stores values as key-value pairs.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class CompositionPropertySet : 
    CompositionObject,
    ICompositionPropertySet,
    ICompositionPropertySet2
  {
    /// <summary>Inserts a Color key-value pair.</summary>
    /// <param name="propertyName">The key associated with the value. This key can be used to retrieve the value.</param>
    /// <param name="value">The value to insert.</param>
    [MethodImpl]
    public extern void InsertColor(string propertyName, Color value);

    [MethodImpl]
    public extern void InsertMatrix3x2(string propertyName, Matrix3x2 value);

    [MethodImpl]
    public extern void InsertMatrix4x4(string propertyName, Matrix4x4 value);

    [MethodImpl]
    public extern void InsertQuaternion(string propertyName, Quaternion value);

    /// <summary>Inserts a Single key-value pair.</summary>
    /// <param name="propertyName">The name of the property to insert.</param>
    /// <param name="value">The value of the property to insert.</param>
    [MethodImpl]
    public extern void InsertScalar(string propertyName, float value);

    [MethodImpl]
    public extern void InsertVector2(string propertyName, Vector2 value);

    [MethodImpl]
    public extern void InsertVector3(string propertyName, Vector3 value);

    [MethodImpl]
    public extern void InsertVector4(string propertyName, Vector4 value);

    /// <summary>Retrieves the specified Color property value.</summary>
    /// <param name="propertyName">The name of the property to retrieve.</param>
    /// <param name="value">If the operation is successful, this parameter will contain the specified Color property value when the method returns.</param>
    /// <returns>Returns a CompositionGetValueStatus value indicating the outcome of retrieving the key-value pair.</returns>
    [MethodImpl]
    public extern CompositionGetValueStatus TryGetColor(
      string propertyName,
      out Color value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetMatrix3x2(
      string propertyName,
      out Matrix3x2 value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetMatrix4x4(
      string propertyName,
      out Matrix4x4 value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetQuaternion(
      string propertyName,
      out Quaternion value);

    /// <summary>Retrieves the specified Single property value.</summary>
    /// <param name="propertyName">The name of the property to retrieve.</param>
    /// <param name="value">If the operation is successful, this parameter will contain the specified Single property value when the method returns.</param>
    /// <returns>Returns a CompositionGetValueStatus value indicating the outcome of retrieving the key-value pair.</returns>
    [MethodImpl]
    public extern CompositionGetValueStatus TryGetScalar(
      string propertyName,
      out float value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetVector2(
      string propertyName,
      out Vector2 value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetVector3(
      string propertyName,
      out Vector3 value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetVector4(
      string propertyName,
      out Vector4 value);

    /// <summary>Inserts a boolean key-value pair.</summary>
    /// <param name="propertyName">The key associated with the value. This key can be used to retrieve the value.</param>
    /// <param name="value">The value to insert.</param>
    [MethodImpl]
    public extern void InsertBoolean(string propertyName, bool value);

    /// <summary>Retrieves the specified boolean property value.</summary>
    /// <param name="propertyName">The name of the property to retrieve.</param>
    /// <param name="value">If the operation is successful, this parameter will contain the specified boolean property value when the method returns.</param>
    /// <returns>Returns a CompositionGetValueStatus value indicating the outcome of retrieving the key-value pair.</returns>
    [MethodImpl]
    public extern CompositionGetValueStatus TryGetBoolean(
      string propertyName,
      out bool value);
  }
}
