// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class MaintenanceWindowOptionsData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(MaintenanceWindowCycles))
            {
                writer.WritePropertyName("maintenanceWindowCycles");
                writer.WriteStartArray();
                foreach (var item in MaintenanceWindowCycles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MinDurationInMinutes))
            {
                writer.WritePropertyName("minDurationInMinutes");
                writer.WriteNumberValue(MinDurationInMinutes.Value);
            }
            if (Optional.IsDefined(DefaultDurationInMinutes))
            {
                writer.WritePropertyName("defaultDurationInMinutes");
                writer.WriteNumberValue(DefaultDurationInMinutes.Value);
            }
            if (Optional.IsDefined(MinCycles))
            {
                writer.WritePropertyName("minCycles");
                writer.WriteNumberValue(MinCycles.Value);
            }
            if (Optional.IsDefined(TimeGranularityInMinutes))
            {
                writer.WritePropertyName("timeGranularityInMinutes");
                writer.WriteNumberValue(TimeGranularityInMinutes.Value);
            }
            if (Optional.IsDefined(AllowMultipleMaintenanceWindowsPerCycle))
            {
                writer.WritePropertyName("allowMultipleMaintenanceWindowsPerCycle");
                writer.WriteBooleanValue(AllowMultipleMaintenanceWindowsPerCycle.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MaintenanceWindowOptionsData DeserializeMaintenanceWindowOptionsData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<bool> isEnabled = default;
            Optional<IList<MaintenanceWindowTimeRange>> maintenanceWindowCycles = default;
            Optional<int> minDurationInMinutes = default;
            Optional<int> defaultDurationInMinutes = default;
            Optional<int> minCycles = default;
            Optional<int> timeGranularityInMinutes = default;
            Optional<bool> allowMultipleMaintenanceWindowsPerCycle = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("isEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindowCycles"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<MaintenanceWindowTimeRange> array = new List<MaintenanceWindowTimeRange>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MaintenanceWindowTimeRange.DeserializeMaintenanceWindowTimeRange(item));
                            }
                            maintenanceWindowCycles = array;
                            continue;
                        }
                        if (property0.NameEquals("minDurationInMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minDurationInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("defaultDurationInMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultDurationInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minCycles"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minCycles = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("timeGranularityInMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            timeGranularityInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("allowMultipleMaintenanceWindowsPerCycle"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowMultipleMaintenanceWindowsPerCycle = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MaintenanceWindowOptionsData(id, name, type, systemData, Optional.ToNullable(isEnabled), Optional.ToList(maintenanceWindowCycles), Optional.ToNullable(minDurationInMinutes), Optional.ToNullable(defaultDurationInMinutes), Optional.ToNullable(minCycles), Optional.ToNullable(timeGranularityInMinutes), Optional.ToNullable(allowMultipleMaintenanceWindowsPerCycle));
        }
    }
}
