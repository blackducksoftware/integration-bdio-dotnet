﻿/*******************************************************************************
 * Copyright (C) 2017 Black Duck Software, Inc.
 * http://www.blackducksoftware.com/
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements. See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership. The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations
 * under the License.
 *******************************************************************************/
using Newtonsoft.Json;

namespace Com.Blackducksoftware.Integration.Hub.Bdio.Simple.Model
{
    public class BdioRelationship
    {
        [JsonProperty(PropertyName = "related")]
        public string Related { get; set; }

        [JsonProperty(PropertyName = "relationshipType")]
        public string RelationshipType { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as BdioRelationship;
            if (other == null)
                return false;
            bool related = Related == other.Related;
            bool relationshipType = RelationshipType == other.RelationshipType;
            return related && relationshipType;
        }

        public override int GetHashCode()
        {
            int result = 7;
            result = 7 * result + Related.GetHashCode();
            result = 7 * result + RelationshipType.GetHashCode();
            return result;
        }
    }
}