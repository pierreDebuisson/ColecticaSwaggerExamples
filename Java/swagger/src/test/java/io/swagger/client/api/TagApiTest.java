/*
 * Colectica Repository REST API
 * Colectica Repository REST API
 *
 * OpenAPI spec version: v1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.api;

import io.swagger.client.ApiException;
import java.util.UUID;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for TagApi
 */
@Ignore
public class TagApiTest {

    private final TagApi api = new TagApi();

    
    /**
     * 
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void apiV1ItemByAgencyByIdByVersionTagByTagDeleteTest() throws ApiException {
        String agency = null;
        UUID id = null;
        Long version = null;
        String tag = null;
        api.apiV1ItemByAgencyByIdByVersionTagByTagDelete(agency, id, version, tag);

        // TODO: test validations
    }
    
    /**
     * 
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void apiV1ItemByAgencyByIdByVersionTagByTagPutTest() throws ApiException {
        String agency = null;
        UUID id = null;
        Long version = null;
        String tag = null;
        api.apiV1ItemByAgencyByIdByVersionTagByTagPut(agency, id, version, tag);

        // TODO: test validations
    }
    
    /**
     * 
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void apiV1ItemByAgencyByIdByVersionTagGetTest() throws ApiException {
        String agency = null;
        UUID id = null;
        Long version = null;
        List<String> response = api.apiV1ItemByAgencyByIdByVersionTagGet(agency, id, version);

        // TODO: test validations
    }
    
}
