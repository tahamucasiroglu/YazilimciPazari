import React from 'react';
import { Formik, Form, Field, ErrorMessage } from 'formik';
import * as Yup from 'yup';

export default function Login() {
  return (
    <div className='container mt-5 '>
      <div className='row justify-content-center'>
        <div className='col-md-6'>
          <h2 className='text-center mb-5'>Giriş Yap</h2>
          <Formik
            initialValues={{ email: '', password: '' }}
            validationSchema={Yup.object({
              email: Yup.string()
                .email('Geçerli bir e-posta adresi girin')
                .required('E-posta zorunludur'),
              password: Yup.string()
                .min(6, 'Şifre en az 6 karakter olmalıdır')
                .required('Şifre zorunludur'),
            })}
            onSubmit={(values) => {
              console.log(values);
              //api işlemleri
            }}
          >
            {() => (
              <Form>
                <div className='form-group mb-3'>
                  <label htmlFor="email">E-posta</label>
                  <Field
                    name="email"
                    type="email"
                    className="form-control"
                  />
                  <ErrorMessage
                    name="email"
                    component="div"
                    className="text-danger"
                  />
                </div>

                <div className='form-group mb-3'>
                  <label htmlFor="password">Şifre</label>
                  <Field
                    name="password"
                    type="password"
                    className="form-control"
                  />
                  <ErrorMessage
                    name="password"
                    component="div"
                    className="text-danger"
                  />
                </div>

                <button className='btn btn-primary w-100' type="submit">
                  Giriş Yap
                </button>
              </Form>
            )}
          </Formik>
        </div>
      </div>
    </div>
  );
}
