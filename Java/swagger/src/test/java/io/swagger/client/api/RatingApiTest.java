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
import io.swagger.client.model.UserRating;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for RatingApi
 */
@Ignore
public class RatingApiTest {

    private final RatingApi api = new RatingApi();

    
    /**
     * 
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void apiV1ItemByAgencyByIdByVersionRatingGetTest() throws ApiException {
        String agency = null;
        UUID id = null;
        String version = null;
        List<UserRating> response = api.apiV1ItemByAgencyByIdByVersionRatingGet(agency, id, version);

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
    public void apiV1ItemByAgencyByIdByVersionRatingPostTest() throws ApiException {
        String agency = null;
        UUID id = null;
        Long version = null;
        Integer rating = null;
        api.apiV1ItemByAgencyByIdByVersionRatingPost(agency, id, version, rating);

        // TODO: test validations
    }
    
}
