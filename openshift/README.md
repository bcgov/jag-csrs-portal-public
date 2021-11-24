## Templates to create openshift components related to CSRS frontend deployment

### Command to execute template
1) Login to OC using login command
2) Run below command in each env. namespaces like dev/test/prod/tools

   ``oc process -f jag-csrs.yaml --param-file=jag-csrs.env | oc apply -f -``


   Credit for the base template files go to jag-CDDS repo contributors/Suganth